using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8callonceEPNS_5FutexEPFvvE")]
[DemangledName("__llvm_libc_20_1_2_::callonce(__llvm_libc_20_1_2_::Futex*, void (*)())")]
internal static partial class callonce_Futex_void
{
	public unsafe static int Invoke(void* flag, void* callback)
	{
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(callonce_impl_callonce_fastpath_Futex.Invoke(flag), expected: true))
		{
			return 0;
		}
		return callonce_impl_callonce_slowpath_Futex_void.Invoke(flag, callback);
	}
}
