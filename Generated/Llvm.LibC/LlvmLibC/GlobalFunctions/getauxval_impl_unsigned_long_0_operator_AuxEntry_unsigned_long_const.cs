using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_18__getauxval_impl__EmENK3$_0clEPNS_8AuxEntryEm")]
[DemangledName("__llvm_libc_20_1_2_::__getauxval_impl__(unsigned long)::$_0::operator()(__llvm_libc_20_1_2_::AuxEntry*, unsigned long) const")]
internal static partial class getauxval_impl_unsigned_long_0_operator_AuxEntry_unsigned_long_const
{
	public unsafe static long Invoke(void* @this, void* auxv, long id)
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
