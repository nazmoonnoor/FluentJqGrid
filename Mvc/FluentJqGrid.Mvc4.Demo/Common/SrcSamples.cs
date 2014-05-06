namespace FluentJqGrid.Mvc4.Demo.Common
{
    public class SrcSamples
    {
        public string ControllerSrc { get; set; }
        public string ViewSrc { get; set; }
        public string Description { get; set; }

        public SrcSamples SetSamples(string view, string controller, string description)
        {
            ViewSrc = view;
            ControllerSrc = controller;
            Description = description;
            return this;
        }
    }
}