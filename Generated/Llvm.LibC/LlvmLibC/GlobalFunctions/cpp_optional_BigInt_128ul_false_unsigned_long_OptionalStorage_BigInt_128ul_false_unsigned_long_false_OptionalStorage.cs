using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm128ELb0EmEEE15OptionalStorageIS3_Lb0EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>, false>::OptionalStorage()")]
internal static partial class cpp_optional_BigInt_128ul_false_unsigned_long_OptionalStorage_BigInt_128ul_false_unsigned_long_false_OptionalStorage
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			*(sbyte*)(&((cpp_optional_BigInt_128_false_OptionalStorage*)@this)->field) = 0;
			((cpp_optional_BigInt_128_false_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
