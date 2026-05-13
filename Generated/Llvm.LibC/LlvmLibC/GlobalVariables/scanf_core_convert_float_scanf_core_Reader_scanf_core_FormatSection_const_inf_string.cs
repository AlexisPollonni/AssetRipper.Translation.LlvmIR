using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZZN19__llvm_libc_20_1_2_10scanf_core13convert_floatEPNS0_6ReaderERKNS0_13FormatSectionEE10inf_string")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_float(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)::inf_string")]
internal static partial class scanf_core_convert_float_scanf_core_Reader_scanf_core_FormatSection_const_inf_string
{
	[FixedAddressValueType]
	private static InlineArray9_SByte __value;

	public unsafe static InlineArray9_SByte* Pointer => unchecked((InlineArray9_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray9_SByte Value
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

	unsafe static scanf_core_convert_float_scanf_core_Reader_scanf_core_FormatSection_const_inf_string()
	{
		Value = InlineArrayHelper.Create<InlineArray9_SByte, byte>("infinity\0"u8);
		PointerIndices.Register(Pointer);
	}
}
