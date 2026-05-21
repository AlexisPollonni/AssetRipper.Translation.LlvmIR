using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class callonce
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8callonceEPNS_5FutexEPFvvE")]
	[DemangledName("__llvm_libc_20_1_2_::callonce(__llvm_libc_20_1_2_::Futex*, void (*)())")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::Futex*")] void* flag, [NativeType("void (*)()")] void* callback)
	{
		if (details_expects_bool_condition_bool.Invoke(callonce_impl_callonce_fastpath.Invoke(flag), expected: true))
		{
			return 0;
		}
		return callonce_impl_callonce_slowpath.Invoke(flag, callback);
	}
}
