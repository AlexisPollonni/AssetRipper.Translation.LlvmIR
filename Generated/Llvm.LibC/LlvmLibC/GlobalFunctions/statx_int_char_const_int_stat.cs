using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_5statxEiPKciP4stat")]
[DemangledName("__llvm_libc_20_1_2_::statx(int, char const*, int, stat*)")]
internal static partial class statx_int_char_const_int_stat
{
	public unsafe static int Invoke(int dirfd, void* path, int flags, void* statbuf)
	{
		anonymous_namespace_statx_buf anonymous_namespace_statx_buf2 = default(anonymous_namespace_statx_buf);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(256L, &anonymous_namespace_statx_buf2);
		llvm_memset_p0_i64.Invoke(&anonymous_namespace_statx_buf2, -86, 256L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = int_syscall_impl_int_int_char_const_int_unsigned_int_anonymous_namespace_statx_buf_long_int_char_const_int_unsigned_int_anonymous_namespace_statx_buf.Invoke(332L, dirfd, path, flags, 2047, &anonymous_namespace_statx_buf2);
		int result;
		if (num < 0)
		{
			result = -num;
		}
		else
		{
			unchecked
			{
				((LlvmLibC.Structures.stat*)statbuf)->st_dev = (uint)((anonymous_namespace_statx_buf2.stx_dev_major << 8) | anonymous_namespace_statx_buf2.stx_dev_minor);
				((LlvmLibC.Structures.stat*)statbuf)->st_ino = anonymous_namespace_statx_buf2.stx_ino;
				((LlvmLibC.Structures.stat*)statbuf)->st_mode = (ushort)anonymous_namespace_statx_buf2.stx_mode;
				((LlvmLibC.Structures.stat*)statbuf)->st_nlink = (uint)anonymous_namespace_statx_buf2.stx_nlink;
				((LlvmLibC.Structures.stat*)statbuf)->st_uid = anonymous_namespace_statx_buf2.stx_uid;
				((LlvmLibC.Structures.stat*)statbuf)->st_gid = anonymous_namespace_statx_buf2.stx_gid;
				((LlvmLibC.Structures.stat*)statbuf)->st_rdev = (uint)((anonymous_namespace_statx_buf2.stx_rdev_major << 8) | anonymous_namespace_statx_buf2.stx_rdev_minor);
				((LlvmLibC.Structures.stat*)statbuf)->st_size = anonymous_namespace_statx_buf2.stx_size;
				long tv_sec = anonymous_namespace_statx_buf2.stx_atime.tv_sec;
				((LlvmLibC.Structures.stat*)statbuf)->st_atim.tv_sec = tv_sec;
				long tv_nsec = (uint)anonymous_namespace_statx_buf2.stx_atime.tv_nsec;
				((LlvmLibC.Structures.stat*)statbuf)->st_atim.tv_nsec = tv_nsec;
				long tv_sec2 = anonymous_namespace_statx_buf2.stx_mtime.tv_sec;
				((LlvmLibC.Structures.stat*)statbuf)->st_mtim.tv_sec = tv_sec2;
				long tv_nsec2 = (uint)anonymous_namespace_statx_buf2.stx_mtime.tv_nsec;
				((LlvmLibC.Structures.stat*)statbuf)->st_mtim.tv_nsec = tv_nsec2;
				long tv_sec3 = anonymous_namespace_statx_buf2.stx_ctime.tv_sec;
				((LlvmLibC.Structures.stat*)statbuf)->st_ctim.tv_sec = tv_sec3;
				long tv_nsec3 = (uint)anonymous_namespace_statx_buf2.stx_ctime.tv_nsec;
				((LlvmLibC.Structures.stat*)statbuf)->st_ctim.tv_nsec = tv_nsec3;
				((LlvmLibC.Structures.stat*)statbuf)->st_blksize = (uint)anonymous_namespace_statx_buf2.stx_blksize;
				((LlvmLibC.Structures.stat*)statbuf)->st_blocks = anonymous_namespace_statx_buf2.stx_blocks;
				result = 0;
			}
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(256L, &anonymous_namespace_statx_buf2);
		return result;
	}
}
