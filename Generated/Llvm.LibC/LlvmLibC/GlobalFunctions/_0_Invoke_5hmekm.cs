using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_5hmekm
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_15__memmem_impl__EPKvmS1_mENK3$_0clEhh")]
	[DemangledName("__llvm_libc_20_1_2_::__memmem_impl__(void const*, unsigned long, void const*, unsigned long)::$_0::operator()(unsigned char, unsigned char) const")]
	[CleanName("_0_Invoke")]
	public unsafe static int Invoke([MangledName("this")] void* This, [MangledName("l")][NativeType("unsigned char")] sbyte L, [MangledName("r")][NativeType("unsigned char")] sbyte R)
	{
		return unchecked((byte)L) - unchecked((byte)R);
	}
}
