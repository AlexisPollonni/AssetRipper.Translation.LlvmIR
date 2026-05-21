using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_BigInt_320ul_false_unsigned_long_false_OptionalStorage_BigInt_320ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm320ELb0EmEEE15OptionalStorageIS3_Lb0EEC2IJS3_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>, false>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>&&)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* This, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>&&")] void* Args)
	{
		unchecked
		{
			Llvm_memcpy_p0_p0_i64.Invoke(&((Llvm_libc_20_1_2_cpp_optional_BigInt_320_false_OptionalStorage*)This)->field, Cpp_forward_BigInt_320ul_false_unsigned_long.Invoke((Llvm_libc_20_1_2_BigInt_76gxx6*)Args), 40L, isVolatile: false);
			((Llvm_libc_20_1_2_cpp_optional_BigInt_320_false_OptionalStorage*)This)->field_1 = 0;
		}
	}
}
