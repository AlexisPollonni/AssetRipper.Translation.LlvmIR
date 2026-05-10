using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5ErrnocviEv")]
[DemangledName("__llvm_libc_20_1_2_::Errno::operator int()")]
[CleanName("Errno_operator_int")]
internal static partial class Errno_operator_int_exthys
{
	public unsafe static int Invoke(void* @this)
	{
		return *unchecked((int*)errno_location.Invoke());
	}
}
