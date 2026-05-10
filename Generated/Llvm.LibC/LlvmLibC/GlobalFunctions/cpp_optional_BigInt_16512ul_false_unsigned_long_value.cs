using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm16512ELb0EmEEE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>>::value() &")]
internal static partial class cpp_optional_BigInt_16512ul_false_unsigned_long_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_tchbah*)@this)->storage.field;
	}
}
