using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class pathconfig
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10pathconfigERK6statfsi")]
	[DemangledName("__llvm_libc_20_1_2_::pathconfig(statfs const&, int)")]
	public unsafe static long Invoke([NativeType("statfs const&")] statfs* s, [NativeType("int")] int name)
	{
		switch (name)
		{
		case 0:
			return link_max.Invoke(s);
		case 13:
			return filesizebits.Invoke(s);
		case 20:
			return symlinks.Invoke(s);
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
			Errno_Assignment.Invoke(libc_errno.Pointer, 22);
			return -1L;
		}
	}
}
