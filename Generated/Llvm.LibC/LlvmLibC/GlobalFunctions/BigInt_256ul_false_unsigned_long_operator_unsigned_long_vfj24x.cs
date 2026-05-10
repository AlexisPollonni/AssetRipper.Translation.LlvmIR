using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator[](unsigned long)")]
[CleanName("BigInt_256ul_false_unsigned_long_operator_unsigned_long")]
internal static partial class BigInt_256ul_false_unsigned_long_operator_unsigned_long_vfj24x
{
	public unsafe static void* Invoke(void* @this, long i)
	{
		return cpp_array_unsigned_long_4ul_operator_unsigned_long.Invoke(&unchecked((BigInt_x9dsed*)@this)->val, i);
	}
}
