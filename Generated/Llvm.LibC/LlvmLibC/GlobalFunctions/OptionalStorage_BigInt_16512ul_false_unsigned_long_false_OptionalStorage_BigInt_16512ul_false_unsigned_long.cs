using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_BigInt_16512ul_false_unsigned_long_false_OptionalStorage_BigInt_16512ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm16512ELb0EmEEE15OptionalStorageIS3_Lb0EEC2IJS3_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>, false>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&&)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] Llvm_libc_20_1_2_cpp_optional_BigInt_16512_false_OptionalStorage* This, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&&")] void* Args)
	{
		Llvm_memcpy_p0_p0_i64.Invoke(&This->field, Cpp_forward_BigInt_16512ul_false_unsigned_long.Invoke(unchecked((Llvm_libc_20_1_2_BigInt_q8g275*)Args)), 2064L, isVolatile: false);
		This->In_use = 0;
	}
}
