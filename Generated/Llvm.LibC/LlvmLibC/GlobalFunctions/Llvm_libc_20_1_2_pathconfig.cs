using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_pathconfig
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10pathconfigERK6statfsi")]
	[DemangledName("__llvm_libc_20_1_2_::pathconfig(statfs const&, int)")]
	public unsafe static long Invoke([MangledName("s")][NativeType("statfs const&")] Statfs* S, [MangledName("name")][NativeType("int")] int Name)
	{
		switch (Name)
		{
		case 0:
			return Llvm_libc_20_1_2_link_max.Invoke(S);
		case 13:
			return Llvm_libc_20_1_2_filesizebits.Invoke(S);
		case 20:
			return Llvm_libc_20_1_2_symlinks.Invoke(S);
		case 16:
			return S->F_bsize;
		case 17:
		case 18:
			return S->F_frsize;
		case 1:
			return 255L;
		case 2:
			return 255L;
		case 3:
			return S->F_namelen;
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
			Errno_Assignment.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer, 22);
			return -1L;
		}
	}
}
