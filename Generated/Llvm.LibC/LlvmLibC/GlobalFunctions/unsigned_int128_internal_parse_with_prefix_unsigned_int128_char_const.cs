using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal17parse_with_prefixIoEET_PKc")]
[DemangledName("unsigned __int128 __llvm_libc_20_1_2_::internal::parse_with_prefix<unsigned __int128>(char const*)")]
internal static partial class unsigned_int128_internal_parse_with_prefix_unsigned_int128_char_const
{
	public unsafe static Struct_fiz2nb Invoke(void* ptr)
	{
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Int128 int4;
		unchecked
		{
			if (ptr == null)
			{
				int4 = 0L;
			}
			else
			{
				if (*(sbyte*)ptr != 48)
				{
					goto IL_00d2;
				}
				if (((sbyte*)ptr)[1] == 98)
				{
					Struct_fiz2nb struct_fiz2nb = unsigned_int128_internal_Parser_unsigned_int128_parse_2_char_const.Invoke((byte*)ptr + 2);
					Int128* num = &@int;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num = struct_fiz2nb2.field_0;
					byte* num2 = (byte*)(&@int) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num2 = struct_fiz2nb3.field_1;
					int4 = @int;
				}
				else
				{
					if (((sbyte*)ptr)[1] != 120)
					{
						goto IL_00d2;
					}
					Struct_fiz2nb struct_fiz2nb4 = unsigned_int128_internal_Parser_unsigned_int128_parse_16_char_const.Invoke((byte*)ptr + 2);
					Int128* num3 = &int2;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num3 = struct_fiz2nb5.field_0;
					byte* num4 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num4 = struct_fiz2nb6.field_1;
					int4 = int2;
				}
			}
			goto IL_0100;
		}
		IL_00d2:
		Struct_fiz2nb struct_fiz2nb7 = unsigned_int128_internal_Parser_unsigned_int128_parse_10_char_const.Invoke(ptr);
		Int128* num5 = &int3;
		Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
		unchecked
		{
			*(long*)num5 = struct_fiz2nb8.field_0;
			byte* num6 = (byte*)(&int3) + 8u;
			Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
			*(long*)num6 = struct_fiz2nb9.field_1;
			int4 = int3;
			goto IL_0100;
		}
		IL_0100:
		return *unchecked((Struct_fiz2nb*)(&int4));
	}
}
