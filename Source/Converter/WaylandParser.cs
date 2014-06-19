using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CHeaderToXML
{
    class WaylandParser : Parser
    {
        public override IEnumerable<XElement> Parse(string[] lines)
        {
            var input = XDocument.Parse(String.Join(" ", lines));
            var elements = new SortedDictionary<string, XElement>();

            foreach (var e in Parse(input))
            {
                var name = e.Attribute("name").Value;
                var version = (e.Attribute("version") ?? new XAttribute("version", String.Empty)).Value;
                var key = name + version;
                if (!elements.ContainsKey(key))
                    elements.Add(key, e);
                else
                    elements[key].Add(e.Elements());
            }

            return elements.Values;
        }

        IEnumerable<XElement> Parse(XDocument input)
        {
            var api = "wl";
            var interfaces = input.Root.Elements("interface");
            foreach (var i in interfaces)
            {
                // The revision number of this interface. We do not
                // actually use this information now (we rely on the "since"
                // attributes of each element inside the interface.)
                var interface_version = i.Attribute("version");

                var enumerations = i.Elements("enum");
                var functions = i.Elements("request");
                var events = i.Elements("event");

                // Build a list of all available tokens.
                var enums = new List<XElement>();
                foreach (var e in enumerations)
                {
                    var x = new XElement("enum",
                        new XAttribute("name", e.Attribute("name").Value),
                        new XAttribute("version", (e.Attribute("since") ?? new XAttribute("since", "1")).Value));

                    foreach (var t in e.Elements("entry"))
                    {
                        x.Add(
                            new XElement("token",
                                new XAttribute("name", t.Attribute("name").Value),
                                new XAttribute("value", t.Attribute("value").Value)));
                    }

                    yield return x;
                }

                foreach (var f in functions)
                {
                    var x = new XElement("function",
                        new XAttribute("name", f.Attribute("name").Value),
                        new XAttribute("version", (e.Attribute("since") ?? new XAttribute("since", "1")).Value));

                    foreach (var a in e.Elements("arg"))
                    {
                        x.Add(
                            new XElement("param",
                                new XAttribute("name", a.Attribute("name").Value),
                                new XAttribute("type", a.Attribute("type").Value)));
                    }

                    yield return x;
                }

                foreach (var e in events)
                {

                }
            }
        }
    }
}
