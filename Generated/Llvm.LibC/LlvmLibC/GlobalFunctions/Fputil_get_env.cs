using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_get_env
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7get_envEP6fenv_t")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::get_env(fenv_t*)")]
	public unsafe static int Invoke([MangledName("envp")][NativeType("fenv_t*")] void* Envp)
	{
		void* ptr = null;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = Envp;
		unchecked
		{
			Internal_get_x87_state_descriptor.Invoke(&((Llvm_libc_20_1_2_fputil_internal_FPState*)ptr)->X87_status);
			int mxcsr = Internal_get_mxcsr.Invoke();
			((Llvm_libc_20_1_2_fputil_internal_FPState*)ptr)->Mxcsr = mxcsr;
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return 0;
		}
	}
}
