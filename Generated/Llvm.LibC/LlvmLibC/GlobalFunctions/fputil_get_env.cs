using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_get_env
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7get_envEP6fenv_t")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::get_env(fenv_t*)")]
	public unsafe static int Invoke([NativeType("fenv_t*")] void* envp)
	{
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = envp;
		unchecked
		{
			internal_get_x87_state_descriptor.Invoke(&((fputil_internal_FPState*)ptr)->x87_status);
			int mxcsr = internal_get_mxcsr.Invoke();
			((fputil_internal_FPState*)ptr)->mxcsr = mxcsr;
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return 0;
		}
	}
}
