using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class statfs_utils_linux_fstatfs
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12statfs_utils13linux_fstatfsEi")]
	[DemangledName("__llvm_libc_20_1_2_::statfs_utils::linux_fstatfs(int)")]
	public unsafe static void Invoke([MangledName("agg.result")] cpp_optional_qbe95b* agg_result, [NativeType("int")] int fd)
	{
		statfs statfs2 = default(statfs);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(120L, &statfs2);
		llvm_memset_p0_i64.Invoke(&statfs2, -86, 120L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = syscall_impl_int_int_statfs.Invoke(138L, fd, &statfs2);
		if (num < 0)
		{
			Errno_Assignment.Invoke(a: -num, @this: libc_errno.Pointer);
			optional_statfs_Constructor.Invoke(agg_result);
		}
		else
		{
			statfs2.f_flags &= -33L;
			optional_statfs_Constructor.Invoke(agg_result, &statfs2);
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(120L, &statfs2);
	}
}
