using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_BigInt_128ul_false_unsigned_long_false_OptionalStorage_BigInt_128ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm128ELb0EmEEE15OptionalStorageIS3_Lb0EEC2IJS3_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>, false>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&&)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* This, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&&")] void* Args)
	{
		unchecked
		{
			Llvm_memcpy_p0_p0_i64.Invoke(&((Cpp_optional_BigInt_128_false_OptionalStorage*)This)->field, Cpp_forward_BigInt_128ul_false_unsigned_long.Invoke((Anon_izyfb7*)Args), 16L, isVolatile: false);
			((Cpp_optional_BigInt_128_false_OptionalStorage*)This)->In_use = 0;
		}
	}
}
