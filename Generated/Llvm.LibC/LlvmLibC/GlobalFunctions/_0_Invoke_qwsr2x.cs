using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_qwsr2x
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_18__getauxval_impl__EmENK3$_0clEPNS_8AuxEntryEm")]
	[DemangledName("__llvm_libc_20_1_2_::__getauxval_impl__(unsigned long)::$_0::operator()(__llvm_libc_20_1_2_::AuxEntry*, unsigned long) const")]
	[CleanName("_0_Invoke")]
	public unsafe static long Invoke([MangledName("this")] void* This, [MangledName("auxv")][NativeType("__llvm_libc_20_1_2_::AuxEntry*")] void* Auxv, [MangledName("id")][NativeType("unsigned long")] long Id)
	{
		long result = 0L;
		void* ptr = null;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = Auxv;
		unchecked
		{
			int num;
			while (true)
			{
				if (((AuxEntry*)ptr)->Tv_sec == 0L)
				{
					num = 2;
					break;
				}
				if (((AuxEntry*)ptr)->Tv_sec == Id)
				{
					result = ((AuxEntry*)ptr)->Tv_nsec;
					num = 1;
					break;
				}
				ptr = (byte*)ptr + sizeof(AuxEntry);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			int num2 = num;
			if (num2 != 2)
			{
				if (num2 != 1)
				{
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
			}
			else
			{
				AuxvErrnoGuard_mark_failure.Invoke((AuxvErrnoGuard*)((Anon_5uk363*)This)->field_0);
				result = 0L;
			}
			return result;
		}
	}
}
