using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm16512ELb0EmEEE15OptionalStorageIS3_Lb0EEC2IJS3_EEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>, false>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&&)")]
internal static partial class cpp_optional_BigInt_16512ul_false_unsigned_long_OptionalStorage_BigInt_16512ul_false_unsigned_long_false_OptionalStorage_BigInt_16512ul_false_unsigned_long_cpp_in_place_t_BigInt_16512ul_false_unsigned_long
{
	public unsafe static void Invoke(cpp_optional_BigInt_16512_false_OptionalStorage* @this, void* args)
	{
		llvm_memcpy_p0_p0_i64.Invoke(&@this->field, BigInt_16512ul_false_unsigned_long_cpp_forward_BigInt_16512ul_false_unsigned_long_cpp_remove_reference_BigInt_16512ul_false_unsigned_long_type.Invoke(unchecked((BigInt_q8g275*)args)), 2064L, isVolatile: false);
		@this->in_use = 0;
	}
}
