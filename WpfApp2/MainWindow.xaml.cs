using System.Diagnostics;
using System.Windows;

namespace WpfApp2 {
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();

      PresentationTraceSources.ResourceDictionarySource.Switch.Level = SourceLevels.All;

      //Application.Current.Resources.MergedDictionaries.Add(this.Resources);

      MySnackbar.MessageQueue.Enqueue("Hello world", "UNDO", () => { });
    }
  }
}
