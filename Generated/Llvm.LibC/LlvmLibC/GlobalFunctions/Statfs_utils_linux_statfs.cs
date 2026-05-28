using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Statfs_utils_linux_statfs
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12statfs_utils12linux_statfsEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::statfs_utils::linux_statfs(char const*)")]
	public unsafe static void Invoke([MangledName("agg.result")] Cpp_optional_qbe95b* Agg_result, [MangledName("path")][NativeType("char const*")] void* Path)
	{
		Statfs statfs = default(Statfs);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(120L, &statfs);
		Llvm_memset_p0_i64.Invoke(&statfs, -86, 120L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_char_const_statfs.Invoke(137L, Path, &statfs);
		if (num < 0)
		{
			Errno_Assignment.Invoke(A: -num, This: Libc_errno.Pointer);
			Optional_statfs_Constructor.Invoke(Agg_result);
		}
		else
		{
			statfs.F_flags &= -33L;
			Optional_statfs_Constructor.Invoke(Agg_result, &statfs);
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(120L, &statfs);
	}
}
