using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE11grab_digitsILm128EEEjRNS_6BigIntIXT_ELb0ENS_8internal16WordTypeSelectorIXT_EE4typeEEE")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::FloatToString<long double, 0>::grab_digits<128ul>(__llvm_libc_20_1_2_::BigInt<128ul, false, __llvm_libc_20_1_2_::internal::WordTypeSelector<128ul>::type>&)")]
internal static partial class unsigned_int_FloatToString_long_double_0_grab_digits_128ul_BigInt_128ul_false_internal_WordTypeSelector_128ul_type
{
	public unsafe static int Invoke(anon_izyfb7* int_num)
	{
		cpp_optional_neprgb cpp_optional_neprgb2 = default(cpp_optional_neprgb);
		llvm_lifetime_start_p0.Invoke(24L, &cpp_optional_neprgb2);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&cpp_optional_neprgb2);
			sbyte* ptr2 = ptr;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			ptr[16] = -86;
			sbyte* ptr3 = ptr + 17;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			ptr3[3] = -86;
			ptr3[4] = -86;
			ptr3[5] = -86;
			ptr3[6] = -86;
			BigInt_128ul_false_unsigned_long_div_uint_half_times_pow_2_unsigned_int_unsigned_long.Invoke(&cpp_optional_neprgb2, int_num, 1953125, 9L);
			int result = BigInt_128ul_false_unsigned_long_operator_unsigned_int_unsigned_int_const.Invoke(cpp_optional_BigInt_128ul_false_unsigned_long_value.Invoke(&cpp_optional_neprgb2));
			llvm_lifetime_end_p0.Invoke(24L, &cpp_optional_neprgb2);
			return result;
		}
	}
}
