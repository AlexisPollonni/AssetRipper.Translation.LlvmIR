using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Futex_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5FutexC2Ej")]
	[DemangledName("__llvm_libc_20_1_2_::Futex::Futex(unsigned int)")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int value)
	{
		Atomic_unsigned_int_Constructor.Invoke(@this, value);
	}
}
