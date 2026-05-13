using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_3appE")]
[DemangledName("__llvm_libc_20_1_2_::app")]
internal static partial class app
{
	[FixedAddressValueType]
	private static AppProperties __value;

	public unsafe static AppProperties* Pointer => unchecked((AppProperties*)Unsafe.AsPointer(ref __value));

	public static AppProperties Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static app()
	{
		PointerIndices.Register(Pointer);
	}
}
