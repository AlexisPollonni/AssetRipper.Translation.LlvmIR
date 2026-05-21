using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_args_to_index
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE13args_to_indexEm")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::args_to_index(unsigned long)")]
	public unsafe static void Invoke(scanf_core_Parser* @this, [NativeType("unsigned long")] long index)
	{
		unchecked
		{
			if ((ulong)@this->args_index > (ulong)index)
			{
				@this->args_index = 1L;
				ArgList_Assignment.Invoke(rhs: &@this->args_start, @this: &@this->args_cur);
			}
			while ((ulong)@this->args_index < (ulong)index)
			{
				ArgList_next_var_void.Invoke(&@this->args_cur);
				@this->args_index++;
			}
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13args_to_indexEm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::args_to_index(unsigned long)")]
	public unsafe static bool Invoke(printf_core_Parser* @this, [NativeType("unsigned long")] long index)
	{
		bool result = false;
		printf_core_TypeDesc printf_core_TypeDesc2 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc3 = default(printf_core_TypeDesc);
		printf_core_TypeDesc printf_core_TypeDesc4 = default(printf_core_TypeDesc);
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
		unchecked
		{
			if ((ulong)@this->args_index > (ulong)index)
			{
				@this->args_index = 1L;
				ArgList_Assignment.Invoke(rhs: &@this->args_start, @this: &@this->args_cur);
			}
			while (true)
			{
				if ((ulong)@this->args_index < (ulong)index)
				{
					llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc2);
					llvm_memset_p0_i64.Invoke(&printf_core_TypeDesc2, 0, 2L, isVolatile: false);
					if ((ulong)@this->args_index <= 128uL)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, (byte*)(&@this->desc_arr) + (nint)(@this->args_index - 1L) * sizeof(printf_core_TypeDesc), 2L, isVolatile: false);
					}
					llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc3);
					*(short*)(&printf_core_TypeDesc3) = printf_core_type_desc_from_type_void_kvifr8.Invoke();
					bool num = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc3);
					llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc3);
					if (num)
					{
						llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc4);
						*(short*)(&printf_core_TypeDesc4) = Parser_internal_ArgList_get_type_desc.Invoke(@this, @this->args_index);
						llvm_memcpy_p0_p0_i64.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc4, 2L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc4);
					}
					llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc5);
					*(short*)(&printf_core_TypeDesc5) = printf_core_type_desc_from_type_void_kvifr8.Invoke();
					bool num2 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc5);
					llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc5);
					int num3;
					if (num2)
					{
						result = false;
						num3 = 1;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc6);
						*(short*)(&printf_core_TypeDesc6) = printf_core_type_desc_from_type_unsigned_int.Invoke();
						bool num4 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc6);
						llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc6);
						if (num4)
						{
							ArgList_next_var_unsigned_int.Invoke(&@this->args_cur);
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc7);
							*(short*)(&printf_core_TypeDesc7) = printf_core_type_desc_from_type_unsigned_long.Invoke();
							bool num5 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc7);
							llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc7);
							if (num5)
							{
								ArgList_next_var_unsigned_long.Invoke(&@this->args_cur);
							}
							else
							{
								llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc8);
								*(short*)(&printf_core_TypeDesc8) = printf_core_type_desc_from_type_double.Invoke();
								bool num6 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc8);
								llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc8);
								if (num6)
								{
									ArgList_next_var_double.Invoke(&@this->args_cur);
								}
								else
								{
									llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc9);
									*(short*)(&printf_core_TypeDesc9) = printf_core_type_desc_from_type_long_double.Invoke();
									bool num7 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc9);
									llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc9);
									if (num7)
									{
										ArgList_next_var_long_double.Invoke(&@this->args_cur);
									}
									else
									{
										llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc10);
										*(short*)(&printf_core_TypeDesc10) = printf_core_type_desc_from_type_short_Fract.Invoke();
										bool num8 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc10);
										llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc10);
										if (num8)
										{
											ArgList_next_var_short_Fract.Invoke(&@this->args_cur);
										}
										else
										{
											llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc11);
											*(short*)(&printf_core_TypeDesc11) = printf_core_type_desc_from_type_Fract.Invoke();
											bool num9 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc11);
											llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc11);
											if (num9)
											{
												ArgList_next_var_Fract.Invoke(&@this->args_cur);
											}
											else
											{
												llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc12);
												*(short*)(&printf_core_TypeDesc12) = printf_core_type_desc_from_type_long_Fract.Invoke();
												bool num10 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc12);
												llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc12);
												if (num10)
												{
													ArgList_next_var_long_Fract.Invoke(&@this->args_cur);
												}
												else
												{
													llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc13);
													*(short*)(&printf_core_TypeDesc13) = printf_core_type_desc_from_type_short_Accum.Invoke();
													bool num11 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc13);
													llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc13);
													if (num11)
													{
														ArgList_next_var_short_Accum.Invoke(&@this->args_cur);
													}
													else
													{
														llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc14);
														*(short*)(&printf_core_TypeDesc14) = printf_core_type_desc_from_type_Accum.Invoke();
														bool num12 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc14);
														llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc14);
														if (num12)
														{
															ArgList_next_var_Accum.Invoke(&@this->args_cur);
														}
														else
														{
															llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc15);
															*(short*)(&printf_core_TypeDesc15) = printf_core_type_desc_from_type_long_Accum.Invoke();
															bool num13 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc15);
															llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc15);
															if (num13)
															{
																ArgList_next_var_long_Accum.Invoke(&@this->args_cur);
															}
															else
															{
																llvm_lifetime_start_p0.Invoke(2L, &printf_core_TypeDesc16);
																*(short*)(&printf_core_TypeDesc16) = printf_core_type_desc_from_type_void_f5fqec.Invoke();
																bool num14 = TypeDesc_Equals.Invoke(&printf_core_TypeDesc2, &printf_core_TypeDesc16);
																llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc16);
																if (num14)
																{
																	ArgList_next_var_void.Invoke(&@this->args_cur);
																}
																else
																{
																	ArgList_next_var_unsigned_int.Invoke(&@this->args_cur);
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						@this->args_index++;
						num3 = 0;
					}
					llvm_lifetime_end_p0.Invoke(2L, &printf_core_TypeDesc2);
					switch (num3)
					{
					case 0:
						continue;
					case 1:
						break;
					default:
						throw new NotImplementedException("Reached LLVM unreachable instruction.");
					}
				}
				else
				{
					result = true;
				}
				break;
			}
			return result;
		}
	}
}
