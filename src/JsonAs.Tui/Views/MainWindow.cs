using JsonAs.Tui.Models;

namespace Terminal.Gui.Views;

public class MainWindow : Window
{
    public JsonAsVM Model { get; }

    public MainWindow(JsonAsVM model)
    {
        Title = "PasteAs";

        var modal = InnerModal();
        Add(modal);

        var strategySelectLbl = StrategySelectLbl(null);
        var strategySelectCombo = StrategySelectCombo(strategySelectLbl);

        modal.Add(
            strategySelectLbl,
            strategySelectCombo
        );
        Model = model;
    }

    private Window InnerModal()
    {
        var modal = new Window
        {
            Width = Dim.Percent(90f),
            Height = 10,
            Title = "Paste Json As...",
            X = Pos.Center(),
            Y = Pos.Center(),
        };

        modal.Border.BorderStyle = BorderStyle.Rounded;
        modal.Border.Effect3D = true;
        modal.Border.Effect3DOffset = new(4, 2);

        return modal;
    }

    private View StrategySelectLbl(View? before = null)
    {
        var strategySelectText = "Json Paste Strategy:";
        var strategySelectTextView = new Label
        {
            Text = strategySelectText,
            X = before?.X ?? 2,
            Y = before?.Y ?? 1,
            Height = 1,
            Width = strategySelectText.Length+2,
        };

        return strategySelectTextView;
    }

    private View StrategySelectCombo(View? before = null)
    {
        var strategySelectComboBox = new ComboBox
        {
            X = before?.X ?? 2,
            Y = (before?.Y ?? 0) + 2,
            Height = 1,
            SelectedItem = 1
        };

        return strategySelectComboBox;
    }
}
