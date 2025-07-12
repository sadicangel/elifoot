//Code for DemoScreenGum
using GumRuntime;
using MonoGameGum;
using MonoGameGum.GueDeriving;
using Elifoot.Components;
using Gum.Converters;
using Gum.DataTypes;
using Gum.Managers;
using Gum.Wireframe;

using RenderingLibrary.Graphics;

using System.Linq;

namespace Elifoot.Screens;
partial class DemoScreenGum : MonoGameGum.Forms.Controls.FrameworkElement
{
    [System.Runtime.CompilerServices.ModuleInitializer]
    public static void RegisterRuntimeType()
    {
        var template = new MonoGameGum.Forms.VisualTemplate((vm, createForms) =>
        {
            var visual = new MonoGameGum.GueDeriving.ContainerRuntime();
            var element = ObjectFinder.Self.GetElementSave("DemoScreenGum");
            element.SetGraphicalUiElement(visual, RenderingLibrary.SystemManagers.Default);
            if(createForms) visual.FormsControlAsObject = new DemoScreenGum(visual);
            visual.Width = 0;
            visual.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
            visual.Height = 0;
            visual.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
            return visual;
        });
        MonoGameGum.Forms.Controls.FrameworkElement.DefaultFormsTemplates[typeof(DemoScreenGum)] = template;
        ElementSaveExtensions.RegisterGueInstantiation("DemoScreenGum", () => 
        {
            var gue = template.CreateContent(null, true) as InteractiveGue;
            return gue;
        });
    }
    public ContainerRuntime DemoSettingsMenu { get; protected set; }
    public NineSliceRuntime Background { get; protected set; }
    public ContainerRuntime MenuTitle { get; protected set; }
    public ContainerRuntime MenuTitle1 { get; protected set; }
    public ContainerRuntime MenuItems { get; protected set; }
    public TextRuntime TitleText { get; protected set; }
    public TextRuntime TitleText1 { get; protected set; }
    public ButtonClose ButtonCloseInstance1 { get; protected set; }
    public DividerHorizontal DividerInstance { get; protected set; }
    public DividerHorizontal DividerInstance4 { get; protected set; }
    public Label ResolutionLabel { get; protected set; }
    public ListBox ResolutionBox { get; protected set; }
    public ButtonStandard DetectResolutionsButton { get; protected set; }
    public ButtonStandard ShowDialogButton { get; protected set; }
    public ButtonStandard ShowToastButton { get; protected set; }
    public CheckBox FullScreenCheckbox { get; protected set; }
    public DividerHorizontal DividerInstance1 { get; protected set; }
    public Label MusicLabel { get; protected set; }
    public Slider MusicSlider { get; protected set; }
    public Label SoundLabel { get; protected set; }
    public Slider SoundSlider { get; protected set; }
    public DividerHorizontal DividerInstance2 { get; protected set; }
    public Label ControlLabel { get; protected set; }
    public RadioButton RadioButtonInstance { get; protected set; }
    public RadioButton RadioButtonInstance1 { get; protected set; }
    public RadioButton RadioButtonInstance2 { get; protected set; }
    public DividerHorizontal DividerInstance3 { get; protected set; }
    public Label DifficultyLabel { get; protected set; }
    public NineSliceRuntime Background1 { get; protected set; }
    public ComboBox ComboBoxInstance { get; protected set; }
    public ContainerRuntime ButtonContainer { get; protected set; }
    public ButtonConfirm ButtonConfirmInstance { get; protected set; }
    public ButtonConfirm WindowOkButton { get; protected set; }
    public ButtonDeny ButtonDenyInstance { get; protected set; }
    public ContainerRuntime DemoDialog { get; protected set; }
    public ContainerRuntime MarginContainer { get; protected set; }
    public Label LabelInstance { get; protected set; }
    public TextBox TextBoxInstance { get; protected set; }
    public PasswordBox TextBoxInstance1 { get; protected set; }
    public TextBox MultiLineTextBox { get; protected set; }
    public NineSliceRuntime DemoHud { get; protected set; }
    public TextRuntime TitleText2 { get; protected set; }
    public ContainerRuntime MenuTitle2 { get; protected set; }
    public PercentBar PercentBarInstance { get; protected set; }
    public PercentBar HitpointsBar1 { get; protected set; }
    public PercentBar HitpointsBar2 { get; protected set; }
    public PercentBar HitpointsBar3 { get; protected set; }
    public PercentBar PercentBarInstance1 { get; protected set; }
    public PercentBar PercentBarInstance2 { get; protected set; }
    public DividerHorizontal DividerInstance5 { get; protected set; }
    public ButtonClose ButtonCloseInstance2 { get; protected set; }
    public PercentBar PercentBarInstance3 { get; protected set; }
    public PercentBar PercentBarInstance4 { get; protected set; }
    public PercentBarIcon PercentBarInstance5 { get; protected set; }
    public ContainerRuntime ContainerInstance { get; protected set; }
    public TreeView TreeViewInstance { get; protected set; }
    public DialogBox DialogBoxInstance { get; protected set; }
    public WindowStandard WindowStandardInstance { get; protected set; }
    public Label LabelInstance1 { get; protected set; }

    public DemoScreenGum(InteractiveGue visual) : base(visual) { }
    public DemoScreenGum()
    {



    }
    protected override void ReactToVisualChanged()
    {
        base.ReactToVisualChanged();
        DemoSettingsMenu = this.Visual?.GetGraphicalUiElementByName("DemoSettingsMenu") as ContainerRuntime;
        Background = this.Visual?.GetGraphicalUiElementByName("Background") as NineSliceRuntime;
        MenuTitle = this.Visual?.GetGraphicalUiElementByName("MenuTitle") as ContainerRuntime;
        MenuTitle1 = this.Visual?.GetGraphicalUiElementByName("MenuTitle1") as ContainerRuntime;
        MenuItems = this.Visual?.GetGraphicalUiElementByName("MenuItems") as ContainerRuntime;
        TitleText = this.Visual?.GetGraphicalUiElementByName("TitleText") as TextRuntime;
        TitleText1 = this.Visual?.GetGraphicalUiElementByName("TitleText1") as TextRuntime;
        ButtonCloseInstance1 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<ButtonClose>(this.Visual,"ButtonCloseInstance1");
        DividerInstance = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<DividerHorizontal>(this.Visual,"DividerInstance");
        DividerInstance4 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<DividerHorizontal>(this.Visual,"DividerInstance4");
        ResolutionLabel = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<Label>(this.Visual,"ResolutionLabel");
        ResolutionBox = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<ListBox>(this.Visual,"ResolutionBox");
        DetectResolutionsButton = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<ButtonStandard>(this.Visual,"DetectResolutionsButton");
        ShowDialogButton = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<ButtonStandard>(this.Visual,"ShowDialogButton");
        ShowToastButton = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<ButtonStandard>(this.Visual,"ShowToastButton");
        FullScreenCheckbox = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<CheckBox>(this.Visual,"FullScreenCheckbox");
        DividerInstance1 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<DividerHorizontal>(this.Visual,"DividerInstance1");
        MusicLabel = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<Label>(this.Visual,"MusicLabel");
        MusicSlider = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<Slider>(this.Visual,"MusicSlider");
        SoundLabel = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<Label>(this.Visual,"SoundLabel");
        SoundSlider = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<Slider>(this.Visual,"SoundSlider");
        DividerInstance2 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<DividerHorizontal>(this.Visual,"DividerInstance2");
        ControlLabel = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<Label>(this.Visual,"ControlLabel");
        RadioButtonInstance = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<RadioButton>(this.Visual,"RadioButtonInstance");
        RadioButtonInstance1 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<RadioButton>(this.Visual,"RadioButtonInstance1");
        RadioButtonInstance2 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<RadioButton>(this.Visual,"RadioButtonInstance2");
        DividerInstance3 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<DividerHorizontal>(this.Visual,"DividerInstance3");
        DifficultyLabel = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<Label>(this.Visual,"DifficultyLabel");
        Background1 = this.Visual?.GetGraphicalUiElementByName("Background1") as NineSliceRuntime;
        ComboBoxInstance = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<ComboBox>(this.Visual,"ComboBoxInstance");
        ButtonContainer = this.Visual?.GetGraphicalUiElementByName("ButtonContainer") as ContainerRuntime;
        ButtonConfirmInstance = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<ButtonConfirm>(this.Visual,"ButtonConfirmInstance");
        WindowOkButton = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<ButtonConfirm>(this.Visual,"WindowOkButton");
        ButtonDenyInstance = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<ButtonDeny>(this.Visual,"ButtonDenyInstance");
        DemoDialog = this.Visual?.GetGraphicalUiElementByName("DemoDialog") as ContainerRuntime;
        MarginContainer = this.Visual?.GetGraphicalUiElementByName("MarginContainer") as ContainerRuntime;
        LabelInstance = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<Label>(this.Visual,"LabelInstance");
        TextBoxInstance = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<TextBox>(this.Visual,"TextBoxInstance");
        TextBoxInstance1 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<PasswordBox>(this.Visual,"TextBoxInstance1");
        MultiLineTextBox = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<TextBox>(this.Visual,"MultiLineTextBox");
        DemoHud = this.Visual?.GetGraphicalUiElementByName("DemoHud") as NineSliceRuntime;
        TitleText2 = this.Visual?.GetGraphicalUiElementByName("TitleText2") as TextRuntime;
        MenuTitle2 = this.Visual?.GetGraphicalUiElementByName("MenuTitle2") as ContainerRuntime;
        PercentBarInstance = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<PercentBar>(this.Visual,"PercentBarInstance");
        HitpointsBar1 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<PercentBar>(this.Visual,"HitpointsBar1");
        HitpointsBar2 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<PercentBar>(this.Visual,"HitpointsBar2");
        HitpointsBar3 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<PercentBar>(this.Visual,"HitpointsBar3");
        PercentBarInstance1 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<PercentBar>(this.Visual,"PercentBarInstance1");
        PercentBarInstance2 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<PercentBar>(this.Visual,"PercentBarInstance2");
        DividerInstance5 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<DividerHorizontal>(this.Visual,"DividerInstance5");
        ButtonCloseInstance2 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<ButtonClose>(this.Visual,"ButtonCloseInstance2");
        PercentBarInstance3 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<PercentBar>(this.Visual,"PercentBarInstance3");
        PercentBarInstance4 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<PercentBar>(this.Visual,"PercentBarInstance4");
        PercentBarInstance5 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<PercentBarIcon>(this.Visual,"PercentBarInstance5");
        ContainerInstance = this.Visual?.GetGraphicalUiElementByName("ContainerInstance") as ContainerRuntime;
        TreeViewInstance = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<TreeView>(this.Visual,"TreeViewInstance");
        DialogBoxInstance = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<DialogBox>(this.Visual,"DialogBoxInstance");
        WindowStandardInstance = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<WindowStandard>(this.Visual,"WindowStandardInstance");
        LabelInstance1 = MonoGameGum.Forms.GraphicalUiElementFormsExtensions.TryGetFrameworkElementByName<Label>(this.Visual,"LabelInstance1");
        CustomInitialize();
    }
    //Not assigning variables because Object Instantiation Type is set to By Name rather than Fully In Code
    partial void CustomInitialize();
}
