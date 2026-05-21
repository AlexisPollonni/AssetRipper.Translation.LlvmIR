using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_grab_digits_128ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE11grab_digitsILm128EEEjRNS_6BigIntIXT_ELb0ENS_8internal16WordTypeSelectorIXT_EE4typeEEE")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::FloatToString<long double, 0>::grab_digits<128ul>(__llvm_libc_20_1_2_::BigInt<128ul, false, __llvm_libc_20_1_2_::internal::WordTypeSelector<128ul>::type>&)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([MangledName("int_num")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, __llvm_libc_20_1_2_::internal::WordTypeSelector<128ul>::type>&")] Anon_izyfb7* Int_num)
	{
		Llvm_libc_20_1_2_cpp_optional_neprgb llvm_libc_20_1_2_cpp_optional_neprgb = default(Llvm_libc_20_1_2_cpp_optional_neprgb);
		Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_neprgb);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_neprgb);
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
			BigInt_128ul_false_unsigned_long_div_uint_half_times_pow_2.Invoke(&llvm_libc_20_1_2_cpp_optional_neprgb, Int_num, 1953125, 9L);
			int result = BigInt_128ul_false_unsigned_long_Unsigned_int_unsigned_int.Invoke(Optional_BigInt_128ul_false_unsigned_long_value.Invoke(&llvm_libc_20_1_2_cpp_optional_neprgb));
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_neprgb);
			return result;
		}
	}
}
