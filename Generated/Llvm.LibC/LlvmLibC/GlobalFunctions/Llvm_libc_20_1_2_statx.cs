using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_statx
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5statxEiPKciP4stat")]
	[DemangledName("__llvm_libc_20_1_2_::statx(int, char const*, int, stat*)")]
	public unsafe static int Invoke([MangledName("dirfd")][NativeType("int")] int Dirfd, [MangledName("path")][NativeType("char const*")] void* Path, [MangledName("flags")][NativeType("int")] int Flags, [MangledName("statbuf")][NativeType("stat*")] global::LlvmLibC.Structures.Stat* Statbuf)
	{
		Anonymous_namespace_statx_buf anonymous_namespace_statx_buf = default(Anonymous_namespace_statx_buf);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(256L, &anonymous_namespace_statx_buf);
		Llvm_memset_p0_i64.Invoke(&anonymous_namespace_statx_buf, -86, 256L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Llvm_libc_20_1_2_syscall_impl_int_int_char_const_int_unsigned_int_anonymous_namespace_statx_buf.Invoke(332L, Dirfd, Path, Flags, 2047, &anonymous_namespace_statx_buf);
		int result;
		if (num < 0)
		{
			result = -num;
		}
		else
		{
			unchecked
			{
				Statbuf->St_dev = (uint)((anonymous_namespace_statx_buf.Stx_dev_major << 8) | anonymous_namespace_statx_buf.Stx_dev_minor);
				Statbuf->St_ino = anonymous_namespace_statx_buf.Stx_ino;
				Statbuf->St_mode = (ushort)anonymous_namespace_statx_buf.Stx_mode;
				Statbuf->St_nlink = (uint)anonymous_namespace_statx_buf.Stx_nlink;
				Statbuf->St_uid = anonymous_namespace_statx_buf.Stx_uid;
				Statbuf->St_gid = anonymous_namespace_statx_buf.Stx_gid;
				Statbuf->St_rdev = (uint)((anonymous_namespace_statx_buf.Stx_rdev_major << 8) | anonymous_namespace_statx_buf.Stx_rdev_minor);
				Statbuf->St_size = anonymous_namespace_statx_buf.Stx_size;
				long tv_sec = anonymous_namespace_statx_buf.Stx_atime.Tv_sec;
				Statbuf->St_atim.Tv_sec = tv_sec;
				long tv_nsec = (uint)anonymous_namespace_statx_buf.Stx_atime.Tv_nsec;
				Statbuf->St_atim.Tv_nsec = tv_nsec;
				long tv_sec2 = anonymous_namespace_statx_buf.Stx_mtime.Tv_sec;
				Statbuf->St_mtim.Tv_sec = tv_sec2;
				long tv_nsec2 = (uint)anonymous_namespace_statx_buf.Stx_mtime.Tv_nsec;
				Statbuf->St_mtim.Tv_nsec = tv_nsec2;
				long tv_sec3 = anonymous_namespace_statx_buf.Stx_ctime.Tv_sec;
				Statbuf->St_ctim.Tv_sec = tv_sec3;
				long tv_nsec3 = (uint)anonymous_namespace_statx_buf.Stx_ctime.Tv_nsec;
				Statbuf->St_ctim.Tv_nsec = tv_nsec3;
				Statbuf->St_blksize = (uint)anonymous_namespace_statx_buf.Stx_blksize;
				Statbuf->St_blocks = anonymous_namespace_statx_buf.Stx_blocks;
				result = 0;
			}
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(256L, &anonymous_namespace_statx_buf);
		return result;
	}
}
