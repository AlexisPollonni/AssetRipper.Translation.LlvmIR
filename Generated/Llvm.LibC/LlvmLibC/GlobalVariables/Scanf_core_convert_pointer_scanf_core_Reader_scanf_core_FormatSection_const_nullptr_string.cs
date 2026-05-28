using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZZN19__llvm_libc_20_1_2_10scanf_core15convert_pointerEPNS0_6ReaderERKNS0_13FormatSectionEE14nullptr_string")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_pointer(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)::nullptr_string")]
internal static partial class Scanf_core_convert_pointer_scanf_core_Reader_scanf_core_FormatSection_const_nullptr_string
{
	[FixedAddressValueType]
	private static InlineArray10_SByte __value;

	public unsafe static InlineArray10_SByte* Pointer => unchecked((InlineArray10_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray10_SByte Value
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

	unsafe static Scanf_core_convert_pointer_scanf_core_Reader_scanf_core_FormatSection_const_nullptr_string()
	{
		Value = InlineArrayHelper.Create<InlineArray10_SByte, byte>("(nullptr)\0"u8);
		_ = Pointer;
	}
}
