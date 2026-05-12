using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13get_type_descEm")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_type_desc(unsigned long)")]
internal static partial class printf_core_Parser_internal_ArgList_get_type_desc_unsigned_long
{
	public unsafe static short Invoke(printf_core_Parser* @this, long index)
	{
		printf_core_TypeDesc printf_core_TypeDesc2 = default(printf_core_TypeDesc);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		printf_core_TypeDesc printf_core_TypeDesc3 = default(printf_core_TypeDesc);
		long num4 = 0L;
		printf_core_TypeDesc printf_core_TypeDesc4 = default(printf_core_TypeDesc);
		printf_core_LengthSpec printf_core_LengthSpec2 = default(printf_core_LengthSpec);
		printf_core_TypeDesc printf_core_TypeDesc5 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc6 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc7 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc8 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc9 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc10 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc11 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc12 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc13 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc14 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc15 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc16 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc17 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc18 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc19 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc20 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc21 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc22 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc23 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc24 = default(printf_core_TypeDesc);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			while (true)
			{
				int num6;
				if (((bool*)@this->str)[num])
				{
					if (((sbyte*)@this->str)[num] != 37)
					{
						goto IL_0b26;
					}
					num++;
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = printf_core_Parser_internal_ArgList_parse_index_unsigned_long.Invoke(@this, &num);
					printf_core_Parser_internal_ArgList_parse_flags_unsigned_long.Invoke(@this, &num);
					if (((sbyte*)@this->str)[num] == 42)
					{
						num++;
						llvm_lifetime_start_p0.Invoke(8L, &num3);
						num3 = printf_core_Parser_internal_ArgList_parse_index_unsigned_long.Invoke(@this, &num);
						long num5 = num3;
						*(short*)(&printf_core_TypeDesc3) = printf_core_TypeDesc_printf_core_type_desc_from_type_int.Invoke();
						printf_core_Parser_internal_ArgList_set_type_desc_unsigned_long_printf_core_TypeDesc.Invoke(@this, num5, *(short*)(&printf_core_TypeDesc3));
						if (num3 == index)
						{
							*(short*)(&printf_core_TypeDesc2) = printf_core_TypeDesc_printf_core_type_desc_from_type_int.Invoke();
							num6 = 1;
						}
						else
						{
							num6 = 0;
						}
						llvm_lifetime_end_p0.Invoke(8L, &num3);
						switch (num6)
						{
						case 0:
							break;
						default:
							goto IL_0b01;
						}
					}
					else if (internal_isdigit_int_149.Invoke(((sbyte*)@this->str)[num]))
					{
						for (; internal_isdigit_int_149.Invoke(((sbyte*)@this->str)[num]); num++)
						{
						}
					}
					if (((sbyte*)@this->str)[num] == 46)
					{
						num++;
						if (((sbyte*)@this->str)[num] == 42)
						{
							num++;
							llvm_lifetime_start_p0.Invoke(8L, &num4);
							num4 = printf_core_Parser_internal_ArgList_parse_index_unsigned_long.Invoke(@this, &num);
							long num7 = num4;
							*(short*)(&printf_core_TypeDesc4) = printf_core_TypeDesc_printf_core_type_desc_from_type_int.Invoke();
							printf_core_Parser_internal_ArgList_set_type_desc_unsigned_long_printf_core_TypeDesc.Invoke(@this, num7, *(short*)(&printf_core_TypeDesc4));
							if (num4 == index)
							{
								*(short*)(&printf_core_TypeDesc2) = printf_core_TypeDesc_printf_core_type_desc_from_type_int.Invoke();
								num6 = 1;
							}
							else
							{
								num6 = 0;
							}
							llvm_lifetime_end_p0.Invoke(8L, &num4);
							switch (num6)
							{
							case 0:
								break;
							default:
								goto IL_0b01;
							}
						}
						else if (internal_isdigit_int_149.Invoke(((sbyte*)@this->str)[num]))
						{
							for (; internal_isdigit_int_149.Invoke(((sbyte*)@this->str)[num]); num++)
							{
							}
						}
					}
					llvm_lifetime_start_p0.Invoke(16L, &printf_core_LengthSpec2);
					*(int*)(&printf_core_LengthSpec2) = -1431655766;
					sbyte* ptr = (sbyte*)(&printf_core_LengthSpec2) + 4;
					*ptr = -86;
					ptr[1] = -86;
					ptr[2] = -86;
					ptr[3] = -86;
					((long*)(&printf_core_LengthSpec2))[1] = -6148914691236517206L;
					Struct_nfiam5 struct_nfiam = printf_core_Parser_internal_ArgList_parse_length_modifier_unsigned_long.Invoke(@this, &num);
					printf_core_LengthSpec* num8 = &printf_core_LengthSpec2;
					Struct_nfiam5 struct_nfiam2 = struct_nfiam;
					*(int*)num8 = struct_nfiam2.field_0;
					byte* num9 = (byte*)(&printf_core_LengthSpec2) + 8u;
					Struct_nfiam5 struct_nfiam3 = struct_nfiam;
					*(long*)num9 = struct_nfiam3.field_1;
					if (num2 == 0L)
					{
						if (((sbyte*)@this->str)[num] != 0)
						{
							num++;
						}
						num6 = 2;
					}
					else
					{
						llvm_memset_p0_i64.Invoke(&printf_core_TypeDesc2, 0, 2L, isVolatile: false);
						switch (((sbyte*)@this->str)[num])
						{
						case 37:
							llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc5);
							*(short*)(&printf_core_TypeDesc5) = printf_core_TypeDesc_printf_core_type_desc_from_type_void_kvifr8.Invoke();
							llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc5, 2L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc5);
							break;
						case 99:
							llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc6);
							*(short*)(&printf_core_TypeDesc6) = printf_core_TypeDesc_printf_core_type_desc_from_type_int.Invoke();
							llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc6, 2L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc6);
							break;
						case 66:
						case 88:
						case 98:
						case 100:
						case 105:
						case 111:
						case 117:
						case 120:
							switch (printf_core_LengthSpec2.lm)
							{
							case LengthModifier_mnvaa2.hh:
							case LengthModifier_mnvaa2.h:
							case LengthModifier_mnvaa2.none:
								llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc7);
								*(short*)(&printf_core_TypeDesc7) = printf_core_TypeDesc_printf_core_type_desc_from_type_int.Invoke();
								llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc7, 2L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc7);
								break;
							case LengthModifier_mnvaa2.l:
								llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc8);
								*(short*)(&printf_core_TypeDesc8) = printf_core_TypeDesc_printf_core_type_desc_from_type_long.Invoke();
								llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc8, 2L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc8);
								break;
							case LengthModifier_mnvaa2.ll:
							case LengthModifier_mnvaa2.L:
								llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc9);
								*(short*)(&printf_core_TypeDesc9) = printf_core_TypeDesc_printf_core_type_desc_from_type_long_long.Invoke();
								llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc9, 2L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc9);
								break;
							case LengthModifier_mnvaa2.j:
								llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc10);
								*(short*)(&printf_core_TypeDesc10) = printf_core_TypeDesc_printf_core_type_desc_from_type_long.Invoke();
								llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc10, 2L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc10);
								break;
							case LengthModifier_mnvaa2.z:
								llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc11);
								*(short*)(&printf_core_TypeDesc11) = printf_core_TypeDesc_printf_core_type_desc_from_type_unsigned_long.Invoke();
								llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc11, 2L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc11);
								break;
							case LengthModifier_mnvaa2.t:
								llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc12);
								*(short*)(&printf_core_TypeDesc12) = printf_core_TypeDesc_printf_core_type_desc_from_type_long.Invoke();
								llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc12, 2L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc12);
								break;
							case LengthModifier_mnvaa2.w:
							case LengthModifier_mnvaa2.wf:
								if ((ulong)printf_core_LengthSpec2.bit_width <= 32uL)
								{
									llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc13);
									*(short*)(&printf_core_TypeDesc13) = printf_core_TypeDesc_printf_core_type_desc_from_type_int.Invoke();
									llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc13, 2L, isVolatile: false);
									llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc13);
								}
								else if ((ulong)printf_core_LengthSpec2.bit_width <= 64uL)
								{
									llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc14);
									*(short*)(&printf_core_TypeDesc14) = printf_core_TypeDesc_printf_core_type_desc_from_type_long.Invoke();
									llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc14, 2L, isVolatile: false);
									llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc14);
								}
								else if ((ulong)printf_core_LengthSpec2.bit_width <= 64uL)
								{
									llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc15);
									*(short*)(&printf_core_TypeDesc15) = printf_core_TypeDesc_printf_core_type_desc_from_type_long_long.Invoke();
									llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc15, 2L, isVolatile: false);
									llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc15);
								}
								else
								{
									llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc16);
									*(short*)(&printf_core_TypeDesc16) = printf_core_TypeDesc_printf_core_type_desc_from_type_long.Invoke();
									llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc16, 2L, isVolatile: false);
									llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc16);
								}
								break;
							}
							break;
						case 65:
						case 69:
						case 70:
						case 71:
						case 97:
						case 101:
						case 102:
						case 103:
							if (printf_core_LengthSpec2.lm != LengthModifier_mnvaa2.L)
							{
								llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc17);
								*(short*)(&printf_core_TypeDesc17) = printf_core_TypeDesc_printf_core_type_desc_from_type_double.Invoke();
								llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc17, 2L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc17);
							}
							else
							{
								llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc18);
								*(short*)(&printf_core_TypeDesc18) = printf_core_TypeDesc_printf_core_type_desc_from_type_long_double.Invoke();
								llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc18, 2L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc18);
							}
							break;
						case 82:
						case 114:
							llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc19);
							*(short*)(&printf_core_TypeDesc19) = printf_core_TypeDesc_printf_core_type_desc_from_type_unsigned_int.Invoke();
							llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc19, 2L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc19);
							break;
						case 75:
						case 107:
							if (printf_core_LengthSpec2.lm == LengthModifier_mnvaa2.l)
							{
								llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc20);
								*(short*)(&printf_core_TypeDesc20) = printf_core_TypeDesc_printf_core_type_desc_from_type_unsigned_long.Invoke();
								llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc20, 2L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc20);
							}
							else
							{
								llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc21);
								*(short*)(&printf_core_TypeDesc21) = printf_core_TypeDesc_printf_core_type_desc_from_type_unsigned_int.Invoke();
								llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc21, 2L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc21);
							}
							break;
						case 110:
						case 112:
						case 115:
							llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc22);
							*(short*)(&printf_core_TypeDesc22) = printf_core_TypeDesc_printf_core_type_desc_from_type_void_i6v7xh.Invoke();
							llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc22, 2L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc22);
							break;
						default:
							llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc23);
							*(short*)(&printf_core_TypeDesc23) = printf_core_TypeDesc_printf_core_type_desc_from_type_int.Invoke();
							llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc23, 2L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc23);
							break;
						}
						long num10 = num2;
						llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc24, &printf_core_TypeDesc2, 2L, isVolatile: false);
						printf_core_Parser_internal_ArgList_set_type_desc_unsigned_long_printf_core_TypeDesc.Invoke(@this, num10, *(short*)(&printf_core_TypeDesc24));
						num6 = ((num2 == index) ? 1 : 0);
					}
					llvm_lifetime_end_p0.Invoke(16L, &printf_core_LengthSpec2);
					goto IL_0b01;
				}
				*(short*)(&printf_core_TypeDesc2) = printf_core_TypeDesc_printf_core_type_desc_from_type_void_kvifr8.Invoke();
				break;
				IL_0b01:
				llvm_lifetime_end_p0.Invoke(8L, &num2);
				int num11 = num6;
				if (num11 != 0)
				{
					if (num11 != 2)
					{
						break;
					}
					continue;
				}
				goto IL_0b26;
				IL_0b26:
				if (((sbyte*)@this->str)[num] != 0)
				{
					num++;
				}
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(short*)(&printf_core_TypeDesc2);
		}
	}
}
