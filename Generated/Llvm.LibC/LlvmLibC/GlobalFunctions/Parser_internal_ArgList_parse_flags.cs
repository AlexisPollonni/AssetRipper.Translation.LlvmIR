using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_parse_flags
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE11parse_flagsEPm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::parse_flags(unsigned long*)")]
	public unsafe static FormatFlags_hin2uh Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_Parser* This, [MangledName("local_pos")][NativeType("unsigned long*")] void* Local_pos)
	{
		sbyte b = 0;
		sbyte b2 = 0;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 1;
		Llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = 0;
		unchecked
		{
			while ((b & 1) == 1)
			{
				switch (((sbyte*)This->Str)[*(long*)Local_pos])
				{
				case 45:
					b2 = (sbyte)((byte)b2 | 1);
					break;
				case 43:
					b2 = (sbyte)((byte)b2 | 2);
					break;
				case 32:
					b2 = (sbyte)((byte)b2 | 4);
					break;
				case 35:
					b2 = (sbyte)((byte)b2 | 8);
					break;
				case 48:
					b2 = (sbyte)((byte)b2 | 0x10);
					break;
				default:
					b = 0;
					break;
				}
				if ((b & 1) == 1)
				{
					(*(long*)Local_pos)++;
				}
			}
			sbyte result = b2;
			Llvm_lifetime_end_p0.Invoke(1L, &b2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			return (FormatFlags_hin2uh)result;
		}
	}
}
