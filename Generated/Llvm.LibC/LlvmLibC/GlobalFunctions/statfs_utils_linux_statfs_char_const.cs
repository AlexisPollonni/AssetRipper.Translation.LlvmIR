using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12statfs_utils12linux_statfsEPKc")]
[DemangledName("__llvm_libc_20_1_2_::statfs_utils::linux_statfs(char const*)")]
internal static partial class statfs_utils_linux_statfs_char_const
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_optional_hij69m* agg_result, void* path)
	{
		statfs statfs2 = default(statfs);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(120L, &statfs2);
		llvm_memset_p0_i64.Invoke(&statfs2, -86, 120L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = int_syscall_impl_int_char_const_statfs_long_char_const_statfs.Invoke(137L, path, &statfs2);
		if (num < 0)
		{
			Errno_operator_int_dntwiy.Invoke(a: -num, @this: libc_errno.Pointer);
			cpp_optional_statfs_optional_cpp_nullopt_t.Invoke(agg_result);
		}
		else
		{
			statfs2.f_flags &= -33L;
			cpp_optional_statfs_optional_statfs.Invoke(agg_result, &statfs2);
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(120L, &statfs2);
	}
}
