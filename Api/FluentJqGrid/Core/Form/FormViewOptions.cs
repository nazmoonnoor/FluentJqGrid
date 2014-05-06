namespace FluentJqGrid.Core.Form
{
    internal class FormViewOptions
    {
        internal int? Top { get; set; }
        internal int? Left { get; set; }
        internal int? Width { get; set; }
        internal int? Height { get; set; }
        internal int? DataHeight { get; set; }
        internal bool? Modal { get; set; }
        internal bool? Drag { get; set; }
        internal bool? Resize { get; set; }
        internal string TopInfo { get; set; }
        internal string BottomInfo { get; set; }
        internal string CloseIcon { get; set; }
        internal string NavKeys { get; set; }
        internal bool? ViewPagerButtons { get; set; }
        internal string LabelsWidth { get; set; }
        internal bool? JqModal { get; set; }
        internal bool? CloseOnEscape { get; set; }
        internal int? ZIndex { get; set; }

        internal string OnClose { get; set; }
        internal string BeforeShowForm { get; set; }
    }
}