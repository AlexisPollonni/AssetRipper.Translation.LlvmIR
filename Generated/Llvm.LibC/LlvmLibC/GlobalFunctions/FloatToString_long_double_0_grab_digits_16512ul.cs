using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_grab_digits_16512ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE11grab_digitsILm16512EEEjRNS_6BigIntIXT_ELb0ENS_8internal16WordTypeSelectorIXT_EE4typeEEE")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::FloatToString<long double, 0>::grab_digits<16512ul>(__llvm_libc_20_1_2_::BigInt<16512ul, false, __llvm_libc_20_1_2_::internal::WordTypeSelector<16512ul>::type>&)")]
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([MangledName("int_num")][NativeType("__llvm_libc_20_1_2_::BigInt<16512ul, false, __llvm_libc_20_1_2_::internal::WordTypeSelector<16512ul>::type>&")] BigInt_q8g275* Int_num)
	{
		Cpp_optional_he65ea cpp_optional_he65ea = default(Cpp_optional_he65ea);
		Llvm_lifetime_start_p0.Invoke(2072L, &cpp_optional_he65ea);
		Llvm_memset_p0_i64.Invoke(&cpp_optional_he65ea, -86, 2072L, isVolatile: false);
		BigInt_16512ul_false_unsigned_long_div_uint_half_times_pow_2.Invoke(&cpp_optional_he65ea, Int_num, 1953125, 9L);
		int result = BigInt_16512ul_false_unsigned_long_Unsigned_int_unsigned_int.Invoke(Optional_BigInt_16512ul_false_unsigned_long_value.Invoke(&cpp_optional_he65ea));
		Llvm_lifetime_end_p0.Invoke(2072L, &cpp_optional_he65ea);
		return result;
	}
}
