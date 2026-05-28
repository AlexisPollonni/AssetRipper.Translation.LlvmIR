using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scanf_core_write_int_with_length
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core21write_int_with_lengthEmRKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::write_int_with_length(unsigned long, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
	public unsafe static void Invoke([MangledName("output_val")][NativeType("unsigned long")] long Output_val, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::scanf_core::FormatSection const&")] Scanf_core_FormatSection* To_conv)
	{
		void* ptr = null;
		int num = 0;
		unchecked
		{
			if (((byte)To_conv->Flags & 1) != 0)
			{
				return;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = To_conv->Output_ptr;
			int num2;
			if (To_conv->Conv_name == 112)
			{
				*(IntPtr*)ptr = (nint)Output_val;
				num2 = 1;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (int)To_conv->Length_modifier;
				switch (num)
				{
				case 0:
					*(sbyte*)ptr = (sbyte)Output_val;
					break;
				case 1:
					*(short*)ptr = (short)Output_val;
					break;
				case 8:
					*(int*)ptr = (int)Output_val;
					break;
				case 2:
					*(long*)ptr = Output_val;
					break;
				case 3:
				case 7:
					*(long*)ptr = Output_val;
					break;
				case 4:
					*(long*)ptr = Output_val;
					break;
				case 5:
					*(long*)ptr = Output_val;
					break;
				case 6:
					*(long*)ptr = Output_val;
					break;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				num2 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			switch (num2)
			{
			case 0:
			case 1:
				return;
			}
			throw new NotImplementedException("Reached LLVM unreachable instruction.");
		}
	}
}
