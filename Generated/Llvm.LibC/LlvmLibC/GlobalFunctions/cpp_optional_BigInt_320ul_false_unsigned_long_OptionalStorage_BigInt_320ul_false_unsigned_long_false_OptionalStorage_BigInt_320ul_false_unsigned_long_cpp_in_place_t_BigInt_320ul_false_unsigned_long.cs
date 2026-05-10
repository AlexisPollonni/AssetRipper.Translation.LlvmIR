using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm320ELb0EmEEE15OptionalStorageIS3_Lb0EEC2IJS3_EEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>, false>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>&&)")]
internal static partial class cpp_optional_BigInt_320ul_false_unsigned_long_OptionalStorage_BigInt_320ul_false_unsigned_long_false_OptionalStorage_BigInt_320ul_false_unsigned_long_cpp_in_place_t_BigInt_320ul_false_unsigned_long
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((cpp_optional_BigInt_320_false_OptionalStorage*)@this)->field, BigInt_320ul_false_unsigned_long_cpp_forward_BigInt_320ul_false_unsigned_long_cpp_remove_reference_BigInt_320ul_false_unsigned_long_type.Invoke(args), 40L, isVolatile: false);
			((cpp_optional_BigInt_320_false_OptionalStorage*)@this)->field_1 = 0;
		}
	}
}
