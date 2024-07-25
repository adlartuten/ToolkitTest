using CommunityToolkit.Mvvm.ComponentModel;

namespace ToolkitTest;

public enum TestEnum
{
    A, B
}
public partial class TestViewModel : ObservableObject
{
    [ObservableProperty]
    private TestModel _model;

    public TestViewModel()
    {
        Model = new TestModel();
    }
}

public partial class TestModel : ObservableObject
{
    [ObservableProperty]
    private TestEnum _testEnumValue;
}
