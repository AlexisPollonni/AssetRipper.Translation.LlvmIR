using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_read_entry
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L10read_entryEi")]
	[DemangledName("__llvm_libc_20_1_2_::read_entry(int)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("fd")][NativeType("int")] int Fd)
	{
		Llvm_libc_20_1_2_AuxEntry llvm_libc_20_1_2_AuxEntry = default(Llvm_libc_20_1_2_AuxEntry);
		long num = 0L;
		void* ptr = null;
		long num2 = 0L;
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_AuxEntry) = -6148914691236517206L;
			((long*)(&llvm_libc_20_1_2_AuxEntry))[1] = -6148914691236517206L;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 16L;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = &llvm_libc_20_1_2_AuxEntry;
			while ((ulong)num > 0uL)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = ((delegate*<int, void*, long, long>)Read.__pointer)(Fd, ptr, num);
				int num3;
				if (num2 < 0L)
				{
					if (Errno_ToInt32.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer) == 4)
					{
						num3 = 2;
					}
					else
					{
						llvm_libc_20_1_2_AuxEntry.Tv_sec = 0L;
						llvm_libc_20_1_2_AuxEntry.Tv_nsec = 0L;
						num3 = 3;
					}
				}
				else
				{
					ptr = (byte*)ptr + num2;
					num -= num2;
					num3 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
				switch (num3)
				{
				case 0:
				case 2:
					continue;
				case 3:
					break;
				default:
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
				break;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_AuxEntry);
		}
	}
}
