using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Callonce
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8callonceEPNS_5FutexEPFvvE")]
	[DemangledName("__llvm_libc_20_1_2_::callonce(__llvm_libc_20_1_2_::Futex*, void (*)())")]
	public unsafe static int Invoke([MangledName("flag")][NativeType("__llvm_libc_20_1_2_::Futex*")] void* Flag, [MangledName("callback")][NativeType("void (*)()")] void* Callback)
	{
		if (Details_expects_bool_condition_bool.Invoke(Callonce_impl_callonce_fastpath.Invoke(Flag), Expected: true))
		{
			return 0;
		}
		return Callonce_impl_callonce_slowpath.Invoke(Flag, Callback);
	}
}
