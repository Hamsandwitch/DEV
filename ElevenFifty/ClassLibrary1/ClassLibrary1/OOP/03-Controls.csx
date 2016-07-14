public abstract class Element
{
    public string Id { get; set; }
    public string Style { get; set; }
}

public class Anchor
{
    public string Text { get; set; }
    public string Url { get; set; }
    public string Target { get; set; }


}

public class Paragraph
    : Element
{
    public string Text { get; set; }

}

var elements = new List<Element>();