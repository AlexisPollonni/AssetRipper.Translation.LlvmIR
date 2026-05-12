using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10pathconfigERK6statfsi")]
[DemangledName("__llvm_libc_20_1_2_::pathconfig(statfs const&, int)")]
internal static partial class pathconfig_statfs_const_int
{
	public unsafe static long Invoke(statfs* s, int name)
	{
		switch (name)
		{
		case 0:
			return link_max_statfs_const.Invoke(s);
		case 13:
			return filesizebits_statfs_const.Invoke(s);
		case 20:
			return symlinks_statfs_const.Invoke(s);
		case 16:
			return s->f_bsize;
		case 17:
		case 18:
			return s->f_frsize;
		case 1:
			return 255L;
		case 2:
			return 255L;
		case 3:
			return s->f_namelen;
		case 4:
			return 256L;
		case 5:
			return 512L;
		case 6:
			return 0L;
		case 7:
			return 1L;
		case 8:
			return 0L;
		case 9:
		case 10:
		case 11:
		case 14:
		case 15:
		case 19:
			return -1L;
		default:
			Errno_operator_int_dntwiy.Invoke(libc_errno.Pointer, 22);
			return -1L;
		}
	}
}
