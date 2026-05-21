using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Statfs_utils_statfs_to_statvfs
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12statfs_utils17statfs_to_statvfsERK6statfs")]
	[DemangledName("__llvm_libc_20_1_2_::statfs_utils::statfs_to_statvfs(statfs const&)")]
	public unsafe static void Invoke([MangledName("agg.result")] LlvmLibC.Structures.Statvfs* Agg_result, [MangledName("in")][NativeType("statfs const&")] Statfs* In)
	{
		Llvm_memset_p0_i64.Invoke(Agg_result, -86, 88L, isVolatile: false);
		Agg_result->F_bsize = In->F_bsize;
		Agg_result->F_frsize = In->F_frsize;
		Agg_result->F_blocks = In->F_blocks;
		Agg_result->F_bfree = In->F_bfree;
		Agg_result->F_bavail = In->F_bavail;
		Agg_result->F_files = In->F_files;
		Agg_result->F_ffree = In->F_ffree;
		Agg_result->F_favail = In->F_ffree;
		unchecked
		{
			Agg_result->F_fsid = *(int*)(&In->F_fsid.Val);
			long num = (long)((int*)(&In->F_fsid.Val))[1] << 32;
			Agg_result->F_fsid |= num;
			Agg_result->F_flag = In->F_flags;
			Agg_result->F_namemax = In->F_namelen;
		}
	}
}
