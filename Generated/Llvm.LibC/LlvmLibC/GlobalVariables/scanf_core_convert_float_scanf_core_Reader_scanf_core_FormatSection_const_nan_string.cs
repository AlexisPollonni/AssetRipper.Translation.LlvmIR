using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZZN19__llvm_libc_20_1_2_10scanf_core13convert_floatEPNS0_6ReaderERKNS0_13FormatSectionEE10nan_string")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_float(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)::nan_string")]
internal static partial class scanf_core_convert_float_scanf_core_Reader_scanf_core_FormatSection_const_nan_string
{
	[FixedAddressValueType]
	private static InlineArray4_SByte __value;

	public unsafe static InlineArray4_SByte* Pointer => unchecked((InlineArray4_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray4_SByte Value
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

	unsafe static scanf_core_convert_float_scanf_core_Reader_scanf_core_FormatSection_const_nan_string()
	{
		Value = InlineArrayHelper.Create<InlineArray4_SByte, byte>("nan\0"u8);
		PointerIndices.Register(Pointer);
	}
}
