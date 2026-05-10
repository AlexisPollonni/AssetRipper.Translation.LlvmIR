using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12statfs_utils17statfs_to_statvfsERK6statfs")]
[DemangledName("__llvm_libc_20_1_2_::statfs_utils::statfs_to_statvfs(statfs const&)")]
internal static partial class statfs_utils_statfs_to_statvfs_statfs_const
{
	public unsafe static void Invoke([MangledName("agg.result")] LlvmLibC.Structures.statvfs* agg_result, void* @in)
	{
		llvm_memset_p0_i64.Invoke(agg_result, -86, 88L, isVolatile: false);
		unchecked
		{
			agg_result->f_bsize = ((statfs*)@in)->f_bsize;
			agg_result->f_frsize = ((statfs*)@in)->f_frsize;
			agg_result->f_blocks = ((statfs*)@in)->f_blocks;
			agg_result->f_bfree = ((statfs*)@in)->f_bfree;
			agg_result->f_bavail = ((statfs*)@in)->f_bavail;
			agg_result->f_files = ((statfs*)@in)->f_files;
			agg_result->f_ffree = ((statfs*)@in)->f_ffree;
			agg_result->f_favail = ((statfs*)@in)->f_ffree;
			agg_result->f_fsid = *(int*)(&((statfs*)@in)->f_fsid.val);
			long num = (long)((int*)(&((statfs*)@in)->f_fsid.val))[1] << 32;
			agg_result->f_fsid |= num;
			agg_result->f_flag = ((statfs*)@in)->f_flags;
			agg_result->f_namemax = ((statfs*)@in)->f_namelen;
		}
	}
}
