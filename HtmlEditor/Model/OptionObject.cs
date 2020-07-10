namespace Msl.HtmlEditor
{
    public class OptionObject
    {
        public string Text { get; protected set; }
        public string Value { get; protected set; }
    }

    public class ImageAlignment : OptionObject
    {
        protected ImageAlignment() { }

        public static readonly ImageAlignment Default = new ImageAlignment { Text = "Default", Value = "" };

        public static readonly ImageAlignment Left = new ImageAlignment { Text = "Left", Value = "left" };

        public static readonly ImageAlignment Right = new ImageAlignment { Text = "Right", Value = "right" };

        public static readonly ImageAlignment Top = new ImageAlignment { Text = "Top", Value = "top" };

        public static readonly ImageAlignment Center = new ImageAlignment { Text = "Center", Value = "center" };

        public static readonly ImageAlignment Bottom = new ImageAlignment { Text = "Bottom", Value = "bottom" };
    }

    public class TableHeaderOption : OptionObject
    {
        protected TableHeaderOption() { }

        public static readonly TableHeaderOption Default = new TableHeaderOption { Text = "Default", Value = "Default" };

        public static readonly TableHeaderOption FirstRow = new TableHeaderOption { Text = "First Row", Value = "FirstRow" };

        public static readonly TableHeaderOption FirstColumn = new TableHeaderOption { Text = "First Column", Value = "FirstColumn" };

        public static readonly TableHeaderOption FirstRowAndColumn = new TableHeaderOption { Text = "First Row And Column", Value = "FirstRowAndColumn" };
    }

    public class TableAlignment : OptionObject
    {
        protected TableAlignment() { }

        public static readonly TableAlignment Default = new TableAlignment { Text = "Default", Value = "" };

        public static readonly TableAlignment Center = new TableAlignment { Text = "Center", Value = "center" };

        public static readonly TableAlignment Left = new TableAlignment { Text = "Left", Value = "left" };

        public static readonly TableAlignment Right = new TableAlignment { Text = "Right", Value = "right" };
    }

    public class Unit : OptionObject
    {
        protected Unit() { }

        public static readonly Unit Pixel = new Unit { Text = "px", Value = "px" };
        public static readonly Unit Percentage = new Unit { Text = "%", Value = "%" };
    }
}
