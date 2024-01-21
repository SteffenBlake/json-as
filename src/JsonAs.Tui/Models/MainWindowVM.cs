using JsonAs.Tui.Enums;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Runtime.Serialization;

namespace JsonAs.Tui.Models;

[DataContract]
public class JsonAsVM : ReactiveObject
{
    [Reactive, DataMember]
    public required Strategy Strategy { get; set; } = Strategy.CsClass;

    public required bool Silent { get; set; } = false;
}
