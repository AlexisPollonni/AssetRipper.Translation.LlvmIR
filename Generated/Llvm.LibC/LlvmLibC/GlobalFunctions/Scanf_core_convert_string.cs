using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scanf_core_convert_string
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core14convert_stringEPNS0_6ReaderERKNS0_13FormatSectionE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::convert_string(__llvm_libc_20_1_2_::scanf_core::Reader*, __llvm_libc_20_1_2_::scanf_core::FormatSection const&)")]
	public unsafe static int Invoke([MangledName("reader")][NativeType("__llvm_libc_20_1_2_::scanf_core::Reader*")] Llvm_libc_20_1_2_scanf_core_Reader* Reader, [MangledName("to_conv")][NativeType("__llvm_libc_20_1_2_::scanf_core::FormatSection const&")] Llvm_libc_20_1_2_scanf_core_FormatSection* To_conv)
	{
		long num = 0L;
		void* ptr = null;
		sbyte b = 0;
		long num2 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		num = ((To_conv->Max_width <= 0) ? ((To_conv->Conv_name != 99) ? Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke() : 1L) : To_conv->Max_width);
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = To_conv->Output_ptr;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = Reader_getc.Invoke(Reader);
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = 0L; (ulong)num2 < (ulong)num; num2++)
			{
				if (b == 0)
				{
					break;
				}
				if (To_conv->Conv_name == 115 && Internal_isspace_8ceyuy.Invoke(b))
				{
					break;
				}
				if (To_conv->Conv_name == 91 && !Bitset_256ul_test.Invoke(&To_conv->Scan_set, b))
				{
					break;
				}
				if (((byte)To_conv->Flags & 1) == 0)
				{
					((sbyte*)ptr)[num2] = b;
				}
				b = Reader_getc.Invoke(Reader);
			}
			Reader_ungetc.Invoke(Reader, b);
			if (To_conv->Conv_name != 99 && ((byte)To_conv->Flags & 1) == 0)
			{
				((sbyte*)ptr)[num2] = 0;
			}
			int result = ((num2 == 0L) ? (-3) : 0);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
