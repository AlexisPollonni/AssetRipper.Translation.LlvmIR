using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_3appE")]
[DemangledName("__llvm_libc_20_1_2_::app")]
internal static partial class Llvm_libc_20_1_2_app
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_AppProperties __value;

	public unsafe static Llvm_libc_20_1_2_AppProperties* Pointer => unchecked((Llvm_libc_20_1_2_AppProperties*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_AppProperties Value
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

	unsafe static Llvm_libc_20_1_2_app()
	{
		PointerIndices.Register(Pointer);
	}
}
