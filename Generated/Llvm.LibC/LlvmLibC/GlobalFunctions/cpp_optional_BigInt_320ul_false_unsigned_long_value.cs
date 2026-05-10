using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNO19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm320ELb0EmEEE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>>::value() &&")]
internal static partial class cpp_optional_BigInt_320ul_false_unsigned_long_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return cpp_remove_reference_BigInt_320ul_false_unsigned_long_type_cpp_move_BigInt_320ul_false_unsigned_long_BigInt_320ul_false_unsigned_long.Invoke(&unchecked((cpp_optional_w3bnnt*)@this)->storage.field);
	}
}
