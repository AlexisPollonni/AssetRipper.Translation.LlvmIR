using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5FutexC2Ej")]
[DemangledName("__llvm_libc_20_1_2_::Futex::Futex(unsigned int)")]
internal static partial class Futex_Futex_unsigned_int
{
	public unsafe static void Invoke(void* @this, int value)
	{
		cpp_Atomic_unsigned_int_Atomic_unsigned_int.Invoke(@this, value);
	}
}
