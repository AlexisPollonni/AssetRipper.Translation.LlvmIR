using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L13ACOSF_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::ACOSF_EXCEPTS")]
internal static partial class ACOSF_EXCEPTS
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_wpg668 __value;

	public unsafe static fputil_ExceptValues_wpg668* Pointer => unchecked((fputil_ExceptValues_wpg668*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_wpg668 Value
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

	unsafe static ACOSF_EXCEPTS()
	{
		Value = new fputil_ExceptValues_wpg668
		{
			values = new InlineArrayBuilder<InlineArray4_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
			{
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 847807907,
					rnd_towardzero_result = 1070141402,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1299675741,
					rnd_towardzero_result = 1070141402,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 964846114,
					rnd_towardzero_result = 1070139316,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1182637534,
					rnd_towardzero_result = 1070143488,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
