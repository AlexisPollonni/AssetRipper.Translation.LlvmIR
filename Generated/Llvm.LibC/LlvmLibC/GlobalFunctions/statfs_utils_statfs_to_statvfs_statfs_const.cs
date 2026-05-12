using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12statfs_utils17statfs_to_statvfsERK6statfs")]
[DemangledName("__llvm_libc_20_1_2_::statfs_utils::statfs_to_statvfs(statfs const&)")]
internal static partial class statfs_utils_statfs_to_statvfs_statfs_const
{
	public unsafe static void Invoke([MangledName("agg.result")] LlvmLibC.Structures.statvfs* agg_result, statfs* @in)
	{
		llvm_memset_p0_i64.Invoke(agg_result, -86, 88L, isVolatile: false);
		agg_result->f_bsize = @in->f_bsize;
		agg_result->f_frsize = @in->f_frsize;
		agg_result->f_blocks = @in->f_blocks;
		agg_result->f_bfree = @in->f_bfree;
		agg_result->f_bavail = @in->f_bavail;
		agg_result->f_files = @in->f_files;
		agg_result->f_ffree = @in->f_ffree;
		agg_result->f_favail = @in->f_ffree;
		unchecked
		{
			agg_result->f_fsid = *(int*)(&@in->f_fsid.val);
			long num = (long)((int*)(&@in->f_fsid.val))[1] << 32;
			agg_result->f_fsid |= num;
			agg_result->f_flag = @in->f_flags;
			agg_result->f_namemax = @in->f_namelen;
		}
	}
}
