namespace ToolkitTest;

public partial class TestView : ContentPage
{
    public TestView(TestViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
