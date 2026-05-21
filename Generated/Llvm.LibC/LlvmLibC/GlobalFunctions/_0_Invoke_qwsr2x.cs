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
	public unsafe static long Invoke(void* @this, [NativeType("__llvm_libc_20_1_2_::AuxEntry*")] void* auxv, [NativeType("unsigned long")] long id)
	{
		long result = 0L;
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = auxv;
		unchecked
		{
			int num;
			while (true)
			{
				if (((AuxEntry*)ptr)->tv_sec == 0L)
				{
					num = 2;
					break;
				}
				if (((AuxEntry*)ptr)->tv_sec == id)
				{
					result = ((AuxEntry*)ptr)->tv_nsec;
					num = 1;
					break;
				}
				ptr = (byte*)ptr + sizeof(AuxEntry);
			}
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
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
				AuxvErrnoGuard_mark_failure.Invoke((AuxvErrnoGuard*)((anon_5uk363*)@this)->field_0);
				result = 0L;
			}
			return result;
		}
	}
}
