using System.Windows.Input;

namespace MauiIssues.SwitchCommandByDataTrigger
{
  public partial class MainPage : ContentPage
  {
    bool isSelected = true;
    int count = 0;

    public MainPage()
    {
      InitializeComponent();

      SelectCommand = new Command(OnSelectCommand);
      UnselectCommand = new Command(OnUnselectCommand);

      BindingContext = this;
    }

    public bool IsSelected
    {
      get => isSelected;
      set
      {
        if(isSelected != value)
        {
          isSelected = value;

          OnPropertyChanged(nameof(IsSelected));
        }
      }
    }

    public ICommand SelectCommand { get; }

    public ICommand UnselectCommand { get; }

    private void OnSelectCommand()
    {
      IsSelected = true;
    }

    private void OnUnselectCommand()
    {
      IsSelected = false;
    }
  }
}