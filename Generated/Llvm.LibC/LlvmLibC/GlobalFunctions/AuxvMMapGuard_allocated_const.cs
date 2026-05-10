using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_13AuxvMMapGuard9allocatedEv")]
[DemangledName("__llvm_libc_20_1_2_::AuxvMMapGuard::allocated() const")]
internal static partial class AuxvMMapGuard_allocated_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked(((anon_589mcc*)@this)->field_0 != (void*)(-1L));
	}
}
